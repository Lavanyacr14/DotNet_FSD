import "./NewTodo.css";
import { useState } from "react";
import { useNavigate } from "react-router-dom";

function NewTodo() {

    const [isCompleted, setCompleted] = useState(false);
    const navigate = useNavigate();
    const url = "https://jsonplaceholder.typicode.com/todos";

    function handleFormSubmit(event) {

        console.log("testing button click");
        const newToDo = {
            id: event.target.todoid.value,
            userId: event.target.userid.value,
            title: event.target.title.value,
            completed: isCompleted,
        };
        console.log(newToDo);
        fetch(url, {
            method: "POST",
            body: JSON.stringify(newToDo),
            headers: new Headers({
                "Content-Type": "application/json",
            }),
        })
            .then(res => {
                console.log(res);
                console.log("Data is added")
            });
navigate("/");
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
                <div className="form-check">
                    <input className="form-check-input" type="radio" name="iscompleted" id="completed"
                        onChange={() => {
                            setCompleted(true);
                        }}
                    />
                    <label className="form-check-label" htmlFor="completed">
                        Completed
                    </label>
                </div>
                <div className="form-check">
                    <input className="form-check-input" type="radio" name="iscompleted" id="notcompleted"
                        onChange={() => {
                            setCompleted(false);
                        }}
                    />
                    <label className="form-check-label" htmlFor="notcompleted">
                        Not Completed
                    </label>
                    <hr />
                </div>
                <button type="submit" className="btn btn-success float-end">Submit</button>
            </form>
        </div>
    )
}

export default NewTodo