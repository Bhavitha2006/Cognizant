import React, { Component } from "react";
import "./App.css";

class CountPeople extends Component {

    constructor() {
        super();

        this.state = {
            entryCount: 0,
            exitCount: 0
        };
    }

    UpdateEntry = () => {
        this.setState({
            entryCount: this.state.entryCount + 1
        });
    };

    UpdateExit = () => {
        this.setState({
            exitCount: this.state.exitCount + 1
        });
    };

    render() {

        return (

            <div className="container">

                <div className="box">

                    <button onClick={this.UpdateEntry}>
                        Login
                    </button>

                    <span>
                        {this.state.entryCount} People Entered!!!
                    </span>

                </div>

                <div className="box">

                    <button onClick={this.UpdateExit}>
                        Exit
                    </button>

                    <span>
                        {this.state.exitCount} People Left!!!
                    </span>

                </div>

            </div>

        );

    }

}

export default CountPeople;