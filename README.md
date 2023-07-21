#FinalProject

* Created the Blazor app -   dotnet new blazorserver -o TodoList -f net5.0

* Changed the Directory to TodoList using --     cd TodoList

* Used dotnet watch run to see a live view of the changes iam doing.

* Build a todo list Blazor app --     dotnet new razorcomponent -n Todopage -o Pages

* Created Todo list page and called Todo.razor

* Added the To do list code.

* Included the necessary input files and buttons.

* Added the add new tasks method.

* Added mark tasks as done or not done yet.

* Added the delete method plus I added the delete sub tasks too.

* Applied Filtiring options.

* Added a dropdown button to do the filtiring.

* tried to do the local storage bonus by adding js file and the @using libraries.

* spent a lot of time trying to do it correctly but it wasnt working.

* linked the JS page to the Host.cshtml, but i still faced issues.

* This was my JS code in a file called local-storage.js
                    window.localStorageInterop = {
                        setItem: function (key, value) {
                            localStorage.setItem(key, value);
                        },
                        getItem: function (key) {
                            return localStorage.getItem(key);
                        },
                    };


* Linked the JS code to my host html with this code  --- <script src="local-storage.js"></script>

* It messed up my whole code and stopped working

* I deleted the localstorage method from my main code but iam going to attach it here at the end as I believe it didnt work because of a security concern in the lab computers.

* Added a Validation to handle errors.

* Applied some css code to change the look of the buttons and lables.



*****************************************************************************************
PLEASE FIND THE CODE OF THE BONUS QUESTION Persistence

@using System.Collections.Generic
@using System.Linq
@using System.Text.Json
@using Microsoft.AspNetCore.Components
@page "/todo"

<h3>Number of Items todo: @todos.Count(todo => !todo.IsDone) </h3>
<input placeholder="Somthing todo" @bind="newTodo" />

<label>To do Description: </label>
<input placeholder="Description" @bind="newTodoDescription" />

<label>Due Date: </label>
<input type="date" @bind="newTodoDueDate" />

<button @onclick="AddTodo">Add item</button>


    <ul>
        @foreach (var item in todos.Where(todo => filter == "all" || (filter == "done" && todo.IsDone) || (filter ==
        "notdone" && !todo.IsDone)))
        {
            <li>
                <input type="checkbox" @onclick="(e) => UpdateIsDone(item)" @bind="item.IsDone"> @item.Title
                <button @onclick="(e) => AddSubItem(item)">Add Sub Items</button>
                <button @onclick="(e) => DeleteTodo(item)">Delete todo</button>


                @if (item.SubItems != null)
                {
                    <span># of SubItem: @item.SubItems.Count(e => !e.SubIsDone)</span>
                    <ul>
                        @foreach (var subitem in item.SubItems)
                        {
                            <li>
                                <input type="checkbox" @bind="subitem.SubIsDone"> @subitem.SubTitle
                                <button @onclick="(e) => DeleteSubItem(item, subitem)">Delete Sub Item</button>
                            </li>
                        }
                    </ul>
                }
            </li>
        }
    </ul>

        <label> Filter</label>
        <select @bind="filter">
            <option value="all">All</option>
            <option value="done">Done</option>
            <option value="notdone">Not Done</option>
        </select>
        <ul>
            @foreach (var item in todos.Where(todo => filter == "all" || (filter == "done" && todo.IsDone) || (filter ==
            "notdone" && !todo.IsDone)))
            {
                <li>
                    <input type="checkbox" @bind="item.IsDone"> @item.Title
                </li>
            }
        </ul>

@code
    {
        private List<TodoItem> todos = new();
        private string newTodo;
        private string filter = "all";
        private string newTodoDescription;
        private DateTime newTodoDueDate;
        private IJSRuntime JSRuntime { get; set; }
        private async Task SaveTodosToLocalStorage()
            {
                await JSRuntime.InvokeVoidAsync("localStorageInterop.setItem", "todos", JsonSerializer.Serialize(todos));
            }

        protected override async Task OnInitializedAsync()
            {
                await LoadTodosFromLocalStorage();
            }

        protected async Task LoadTodosFromLocalStorage()
            {
                string todosJson = await JSRuntime.InvokeAsync<string>("localStorageInterop.getItem", "todos");
                if (!string.IsNullOrEmpty(todosJson))
                {
                    todos = JsonSerializer.Deserialize<List<TodoItem>>(todosJson);
                }
            }


    


        private void AddTodo()
            {
                if (!string.IsNullOrWhiteSpace(newTodo))
                {
                    todos.Add(new TodoItem { Title = newTodo, newTodoDescription = newTodoDescription, newTodoDueDate = newTodoDueDate });
                    newTodo = "";
                    newTodoDescription = "";
                    newTodoDueDate = DateTime.Now;
                    SaveTodosToLocalStorage();
                }
            }

        private void AddSubItem(TodoItem currentItem)
            {
                if (!string.IsNullOrWhiteSpace(newTodo))
                {
                    if (currentItem.SubItems == null) currentItem.SubItems = new List<TodoSubItems>();
                    currentItem.SubItems.Add(new TodoSubItems { SubTitle = newTodo });
                    newTodo = "";
                }
            }

        private void UpdateIsDone(TodoItem currentItem)
            {
                if (currentItem.SubItems != null)
                {
                    foreach (var subitem in currentItem.SubItems)
                    {
                        subitem.SubIsDone = true;
                    }

                }
                SaveTodosToLocalStorage();
            }

        private void DeleteTodo(TodoItem currentItem)
            {
                todos.Remove(currentItem);
                SaveTodosToLocalStorage();
            }

        private void DeleteSubItem(TodoItem currentItem, TodoSubItems currentSubItem)
            {
                currentItem.SubItems.Remove(currentSubItem);
                SaveTodosToLocalStorage();
            }

        public class TodoItem
            {
                public string Title { get; set; }
                public bool IsDone { get; set; }
                public List<TodoSubItems> SubItems { get; set; }
                public string newTodoDescription { get; set; }
                public DateTime newTodoDueDate { get; set; }
            }

        public class TodoSubItems
            {
                public string SubTitle { get; set; }
                public bool SubIsDone { get; set; }
            }
    }
