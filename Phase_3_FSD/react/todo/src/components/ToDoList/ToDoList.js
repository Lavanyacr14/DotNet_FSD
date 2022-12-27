import {useEffect, useState} from "react";
import "./ToDoList.css";
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
      <div className="container">
        <a href="/newTodo" className="btn btn-primary float-start">New Todo</a>
        <br/><br/>
        <table class="table table-dark table-striped">
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
</div>
    );
}

export default ToDoList;