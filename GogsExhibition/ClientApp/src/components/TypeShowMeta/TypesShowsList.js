import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class TypesShowList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'typeshows';
    }
}
