import React, { Component } from "react";

class ComplaintRegister extends Component {

  constructor() {
    super();

    this.state = {
      ename: "",
      complaint: "",
      NumberHolder: Math.floor(Math.random() * 100) + 1,
      message: ""
    };
  }

  handleChange = (event) => {
    this.setState({
      [event.target.name]: event.target.value
    });
  };

  handleSubmit = (event) => {

    let msg =
        "Thanks " +
        this.state.ename +
        "\nYour Complaint was Submitted.\nTransaction ID is: " +
        this.state.NumberHolder;

    alert(msg);

    event.preventDefault();

};

  render() {
    return (
      <div className="container">

        {this.state.message && (
          <div className="alertBox">
            {this.state.message.split("\n").map((item, index) => (
              <p key={index}>{item}</p>
            ))}
          </div>
        )}

        <h1 className="title">
          Register your complaints here!!!
        </h1>

        <form onSubmit={this.handleSubmit}>
          <table>
            <tbody>

              <tr>
                <td>Name:</td>
                <td>
                  <input
                    type="text"
                    name="ename"
                    value={this.state.ename}
                    onChange={this.handleChange}
                  />
                </td>
              </tr>

              <tr>
                <td>Complaint:</td>
                <td>
                  <textarea
                    rows="3"
                    cols="20"
                    name="complaint"
                    value={this.state.complaint}
                    onChange={this.handleChange}
                  />
                </td>
              </tr>

              <tr>
                <td></td>
                <td>
                  <button type="submit">
                    Submit
                  </button>
                </td>
              </tr>

            </tbody>
          </table>
        </form>

      </div>
    );
  }
}

export default ComplaintRegister;