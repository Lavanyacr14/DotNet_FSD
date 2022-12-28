import {useEffect, useState} from "react";
import "./Product.css";

function Product() {
    const [product,setProduct] = useState([]);
    const url = "https://jsonplaceholder.typicode.com/todos";
    const initCall = ()=>{
        fetch(url)
        .then(res=>res.json())
        .then(content=> setProduct(content));
}

    useEffect(initCall);
    return(
      <div className="container">
        <a href="/NewProduct" className="btn btn-primary float-start">Add Product</a>
        <button className="btn btn-primary float-end">View User</button>
        <br/><br/>
        <table class="table table-default table-striped">
  <thead>
    <tr>
      <th scope="col">ID</th>
      <th scope="col">User ID</th>
      <th scope="col">Title</th>
      <th scope="col">Completed</th>
      <th scope="col">Edit</th>
      <th scope="col">Delete</th>
    </tr>
  </thead>
  <tbody>
    {
        product &&
        product.map(item=>
            <tr>
            <td>{item.id}</td>
              <td>{item.userId}</td>
              <td>{item.title}</td>
              <td>{item.completed ? 'Yes' : 'No' }</td>
              <td><button className="btn btn-primary float-start">Edit</button></td>
              <td><button className="btn btn-primary float-start">Delete</button></td>
            </tr>
            )
   
    }
  </tbody>
</table>
</div>
    );
}

export default Product;