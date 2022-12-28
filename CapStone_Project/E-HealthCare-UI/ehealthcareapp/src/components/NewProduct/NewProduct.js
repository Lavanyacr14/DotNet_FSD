import "./NewProduct.css";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

function NewProduct() {

    const navigate = useNavigate();
    const url = "https://jsonplaceholder.typicode.com/todos";

    function handleFormSubmit(event) {

        console.log("testing button click");
        const newProduct = {
            id: event.target.todoid.value,
            userId: event.target.userid.value,
            title: event.target.title.value,
            completed: "true",
        };
        console.log(newProduct);
        fetch(url, {
            method: "POST",
            body: JSON.stringify(newProduct),
            headers: new Headers({
                "Content-Type": "application/json",
            }),
        })
            .then(res => {
                console.log(res);
                console.log("Data is added")
            });
navigate("/Product");
    }
    return (

        <div className="container">
            <form onSubmit={handleFormSubmit}>
                <div className="mb-3">
                    <label htmlFor="todoid" className="form-label">Id</label>
                    <input type="number" className="form-control" id="todoid" aria-describedby="emailHelp" />

                </div>
                <div className="mb-3">
                    <label htmlFor="userid" className="form-label">User Id</label>
                    <input type="number" className="form-control" id="userid" />
                </div>
                <div className="mb-3">
                    <label htmlFor="title" className="form-label">Title</label>
                    <input type="text" className="form-control" id="title" />
                </div>
                
                
                <button type="submit" className="btn btn-success float-end">Submit</button>
            </form>
        </div>
    )
}

export default NewProduct;