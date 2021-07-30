import { Modal } from 'bootstrap';
import React, { Component } from 'react';
import "./Object.css";

export class ObjectComponent extends Component {
    baseController;

    constructor(props) {
        super(props);
        //this.baseController = Controller;
    }

    render() {
        return (
                    <h1>YA NOVIY ELEMENT!</h1>)
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
