import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class RoleList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'roles';
    }
}
