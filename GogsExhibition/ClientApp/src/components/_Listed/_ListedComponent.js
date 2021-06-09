import { Modal } from 'bootstrap';
import React, { Component } from 'react';
import { ObjectComponent } from '../_Object/_ObjectComponent';

export class ListedComponent extends Component {
    static displayName = ListedComponent.name;
    baseController;
    modalActive = false;
    setModalActive

    constructor(props, Controller) {
        super(props);
        this.baseController = Controller;
        this.state = { tableData: [], loading: true };
        this.AddNew = this.AddNew.bind(this);
    }

    componentDidMount() {
        this.GetData();
    }

    renderTable() {
        let tableData = this.state.tableData;
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Name</th>
                    </tr>
                </thead>
                <tbody>
                    {tableData.map(Data =>
                        <tr key={Data.id}>
                            <td>{Data.id}</td>
                            <td>{Data.name}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }


    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderTable();

        //let obj = new ObjectComponent(this.props, "sex", this.modalActive, this.setModalActive);

        return (
            <div>
                <h1 id="tabelLabel" >List of {this.baseController}</h1>
                {contents}
                <button onClick={this.AddNew}>
                    Add new element
                </button>
                
            </div>)
    }

    async GetData() {
        const response = await fetch('api/' + this.baseController);
        const data = await response.json();
        this.setState({ tableData: data, loading: false });
    }

    AddNew() {
        this.modalActive = true;
    }
}
