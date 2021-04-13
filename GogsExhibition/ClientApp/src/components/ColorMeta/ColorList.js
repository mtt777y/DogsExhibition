import React, { Component } from 'react';
import { ListedComponent } from './ListedComponent'

export class ColorList extends ListedComponent {
    constructor(prop, controller) {
        super(prop, controller);
        this.baseController = 'colors';
    }
}
