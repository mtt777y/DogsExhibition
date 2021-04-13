import React, { Component } from 'react';
import { ListedComponent } from './ListedComponent'

export class TypesShowList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'typeshows';
    }
}
