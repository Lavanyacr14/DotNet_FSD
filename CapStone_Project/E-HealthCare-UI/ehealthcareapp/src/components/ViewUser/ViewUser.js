import {useEffect, useState} from "react";
import "./ViewUser.css";

function ViewUser() {
    const [ViewUser,setViewUser] = useState([]);
    const url = "https://jsonplaceholder.typicode.com/todos";
    const initCall = ()=>{
        fetch(url)
        .then(res=>res.json())
        .then(content=> setViewUser(content));
}

    useEffect(initCall);
    return(
      <div className="container">
        <h2> Registered Users</h2> 
        <hr/>       
        <table class="table table-default table-striped">
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
        ViewUser &&
        ViewUser.map(item=>
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

export default ViewUser;