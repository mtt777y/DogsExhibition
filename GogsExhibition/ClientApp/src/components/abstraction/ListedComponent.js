import { Modal } from 'bootstrap';
import React, { Component } from 'react';
import App from '../../App';
import ObjectComponent from './ObjectComponent';

export class ListedComponent extends Component {
    static displayName = ListedComponent.name;
    baseController;
    setModalActive

    constructor(props, Controller) {
        super(props);
        this.baseController = Controller;
        this.state = { tableData: [], loading: true, objEditorOpen: false};
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

        let objContent = this.state.objEditorOpen
            ? <p><ObjectComponent controller={this.baseController} /></p>
            : <button onClick={this.AddNew}>
                Add new element
              </button>;

        return (
            <div>
                {objContent}
                <h1 id="tabelLabel" >List of {this.baseController}</h1>
                {contents}            
            </div>)
    }

    async GetData() {
        const requestOptions = {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json',
                'Authorization' : 'Bearer ' + App.token}
        };

        const response = await fetch('api/' + this.baseController, requestOptions);
        const data = await response.json();
        if (response.status == 200) {
            this.setState({ tableData: data, loading: false });
        }
    }

    AddNew() {
        this.setState({objEditorOpen: true });
    }
}
