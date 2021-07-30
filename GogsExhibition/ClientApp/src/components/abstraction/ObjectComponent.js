import { Modal } from 'bootstrap';
import React, { Component } from 'react';
import "./Object.css";

export class ObjectComponent extends Component {
    baseController;

    inputId;
    inputName;

    constructor(props) {
        super(props);
        this.baseController = props.controller;
    }

    render() {
        return (
            <div>
                <em>id:</em>
                <p>
                    <input type="text" name="id" value={this.inputId} onChange={(event) => this.lp.Login = event.target.value}/>
                </p>
                <em>Name:</em>
                <p>
                    <input type="text" name="name" value={this.inputName} onChange={(event) => this.lp.Pass = event.target.value}/>
                </p>
                <p>
                    <button>
                        Save
                    </button>
                </p>
            </div>)
    }

    //async GetData() {
    //    const response = await fetch('api/' + this.baseController);
    //    const data = await response.json();
    //    this.setState({ tableData: data, loading: false });
    //}

    AddNew() {

    }
}

export default ObjectComponent; 
