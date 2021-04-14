import React, { Component } from 'react';
import { ListedComponent } from '../_Listed/_ListedComponent'

export class TypesShowList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'typeshows';
    }
}
