import { Component } from '@angular/core';
import { CategoryService } from '../../services/category.service';
import { Category } from '../../types/category';

@Component ({
    selector:'categories',
    templateUrl: './category.component.html'
})

export class CategoryComponent {

    private _categories: Array<Category>

    constructor(
        private _categoryService: CategoryService
    ){}

    public getCategories() {
        this._categoryService.getcategories()
        .then(res => { 
            this._categories = res;            
        })
        .catch(error =>{
            console.error(error);
        })
    }
}