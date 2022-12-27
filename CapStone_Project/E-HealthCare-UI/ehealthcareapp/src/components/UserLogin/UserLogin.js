function UserLogin() {
    return (
        <div class="container">
            <div class="row">
                <div class="col-sm-12 col-md-6">
                    <h2> Please Sign Up</h2>
                    <hr />
                    <form action="">
                        <div class="mb-3">
                            <label for="fname" class="form-label"> First Name</label>
                            <input type="text" name="fname" class="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="lname" class="form-label"> Last Name</label>
                            <input type="text" name="lname" class="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="email" class="form-label"> Email</label>
                            <input type="text" name="email" class="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="passwd" class="form-label"> Password</label>
                            <input type="password" name="passwd" class="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="dob" class="form-label"> Date Of Birth</label>
                            <input type="date" name="dob" class="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="phno" class="form-label"> Phone Number</label>
                            <input type="text" name="phno" class="form-control" />
                        </div>
                        <div class="input-group">
                            <span class="input-group-text">Address</span>
                            <textarea class="form-control" aria-label="With textarea"></textarea>
                        </div>
                        <button type="submit" class="btn btn-success float-end">Signup</button>
                    </form>
                </div>
            </div>
        </div>
    )
}

export default UserLogin;