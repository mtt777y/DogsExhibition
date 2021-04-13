import React, { Component } from 'react';

export class ListedComponent extends Component {
    static displayName = ListedComponent.name;
    baseController;

    constructor(props, Controller) {
        super(props);
        this.baseController = Controller;
        this.state = { tableData: [], loading: true };
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

        return (
            <div>
                <h1 id="tabelLabel" >List of {this.baseController}</h1>
                {contents}

            </div>)
    }

    async GetData() {
        const response = await fetch('api/' + this.baseController);
        const data = await response.json();
        this.setState({ tableData: data, loading: false });
    }
}
