import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class OwnerList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller, ['Date of Birth', 'Country', 'Sex']) ;
        this.baseController = 'owners';
    }
}
