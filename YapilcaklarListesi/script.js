// ID seçicileri
var addButton = document.getElementById('add-btn');
var inputField = document.getElementById('todo-input');
var todoList = document.getElementById('todo-list');

// Butona tıklayınca yeni todo öğesi ekleyelim
addButton.onclick = function() {
    var todoText = inputField.value.trim();

    if (todoText !== "") {
        // Yeni bir "li" öğesi oluştur
        var newTodo = document.createElement('li');
        newTodo.textContent = todoText;

        // Listeye yeni öğeyi ekle
        todoList.appendChild(newTodo);

        // Input alanını temizle
        inputField.value = '';

        // Yeni öğeye tıklama olayı ekleyelim
        newTodo.onclick = function() {
            newTodo.classList.toggle('completed');
        };
    }
};
