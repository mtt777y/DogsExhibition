import React, { Component } from 'react';
import { ObjectComponent } from '../abstraction/ObjectComponent'

export class SexList extends ObjectComponent {
    constructor(prop, controller, active, setActive) {
        super(prop, controller, active, setActive);
        this.baseController = 'sexes';
    }
}
