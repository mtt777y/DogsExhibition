import React, { Component } from 'react';
import { ListedComponent } from '../abstraction/ListedComponent'

export class ColorList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'colors';
    }
}
