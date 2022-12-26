import {useEffect, useState} from "react";
function ToDoList() {
    const [todos,setTodos] = useState([]);
    const url = "https://jsonplaceholder.typicode.com/todos";
    const initCall = ()=>{
        fetch(url)
        .then(res=>res.json())
        .then(content=> setTodos(content));
}

    useEffect(initCall);
    return(
        <table class="table">
  <thead>
    <tr>
      <th scope="col">ID</th>
      <th scope="col">User ID</th>
      <th scope="col">Title</th>
      <th scope="col">Completed</th>
    </tr>
  </thead>
  <tbody>
    {
        todos &&
        todos.map(item=>
            <tr>
            <td>{item.id}</td>
              <td>{item.userId}</td>
              <td>{item.title}</td>
              <td>{item.completed ? 'Yes' : 'No' }</td>
            </tr>
            )
   
    }
  </tbody>
</table>
    );
}

export default ToDoList;