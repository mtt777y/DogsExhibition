import { Modal } from 'bootstrap';
import React, { Component } from 'react';
import "./_Object.css";

export class ObjectComponent extends Modal {
    static displayName = "Modal";
    baseController;

    constructor(props, Controller, active, setActive) {
        super(props, active, setActive);
        this.baseController = Controller;
    //    this.AddNew = this.AddNew.bind(this);
    }

    //componentDidMount() {
    //}


    render() {
        return (
            <div className='modal'>
                <div className = 'modal__content'>
                    <h1>YA NOVIY {this.baseController} ELEMENT!</h1>
                </div>
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
