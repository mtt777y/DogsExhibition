import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class UserList extends ListedComponent {
    constructor(prop, controller, fields) {
        super(prop, controller, fields);
        this.baseController = 'users';
        this.additionalFields = ['email', 'password', 'dateOfBirth', 'sex', 'role'];
    }
}
