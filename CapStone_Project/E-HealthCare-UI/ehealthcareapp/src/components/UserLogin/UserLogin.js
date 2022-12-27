import { useState } from "react";

function UserLogin() {
    function handleFormSubmit(event) {
        const url = "https://jsonplaceholder.typicode.com/todos";
        const newUser = {
            fname: event.target.fname.value,
            lname: event.target.lname.value,
            email: event.target.email.value,
            password: event.target.passwd.value,
            phno: event.target.phno.value,
            address: event.target.address.value,
        };
        console.log(newUser);
        fetch(url,
            {
                method: "POST",
                body: JSON.stringify(newUser),
            }
        );
        console.log("form submitted");

    };

    return (
        <div className="container">
            <div className="row">
                <div className="col-sm-12 col-md-6">
                    <h2> Please Sign Up</h2>
                    <hr />
                    <form onSubmit={handleFormSubmit}>
                        <div className="mb-3">
                            <label htmlFor="fname" className="form-label"> First Name</label>
                            <input type="text" name="fname" className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="lname" className="form-label"> Last Name</label>
                            <input type="text" name="lname" className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="email" className="form-label"> Email</label>
                            <input type="text" name="email" className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="passwd" className="form-label"> Password</label>
                            <input type="password" name="passwd" className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="dob" className="form-label"> Date Of Birth</label>
                            <input type="date" name="dob" className="form-control" />
                        </div>
                        <div className="mb-3">
                            <label htmlFor="phno" className="form-label"> Phone Number</label>
                            <input type="text" name="phno" className="form-control" />
                        </div>
                        <div className="input-group">
                            <span className="input-group-text">Address</span>
                            <textarea className="form-control" aria-label="With textarea" name="address"></textarea>
                        </div>
                        <br /> <br />
                        <button type="submit" className="btn btn-success float-end">Signup</button>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default UserLogin;