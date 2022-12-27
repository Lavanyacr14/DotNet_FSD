import { useState } from "react";

function UserLogin() {
    function handleFormSubmit(event) {
        const url = "https://jsonplaceholder.typicode.com/todos";
        const loginUser = {
            userid: event.target.userid.value,
            password: event.target.passwd.value,
        };
        console.log(loginUser);
        fetch(url,
            {
                method: "POST",
                body: JSON.stringify(loginUser),
            }
        );
        console.log("User logged in");

    };

    return (
        <div className="container">
            <div className="row">
                <div className="col-sm-12 col-md-6">
                    <h2> Please Sign In</h2>
                    <hr />
                    <form onSubmit={handleFormSubmit}>
                        <div className="mb-3">
                            <label htmlFor="userid" className="form-label"> User Id</label>
                            <input type="text" name="userid" className="form-control" />
                        </div>
                        
                        <div className="mb-3">
                            <label htmlFor="passwd" className="form-label"> Password</label>
                            <input type="password" name="passwd" className="form-control" />
                        </div>        
                        
                        <button type="submit" className="btn btn-success float-end">Sign In</button>
                        <a href="/UserRegister" className="btn btn-success float-start">Register</a>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default UserLogin;