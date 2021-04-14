import React, { Component } from 'react';
import { ObjComponent } from '../_Object/_ObjectComponent'

export class SexList extends ObjComponent {
    constructor(prop, controller, active, setActive) {
        super(prop, controller, active, setActive);
        this.baseController = 'sexes';
    }
}
