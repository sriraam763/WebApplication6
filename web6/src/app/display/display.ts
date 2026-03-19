import { CommonModule } from '@angular/common';
import { Services } from '../services';
import { todo } from './../todolist';
import { ChangeDetectorRef, Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-display',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './display.html',
  styleUrl: './display.css',
})
export class Display {
  task:todo[]=[];

  private cd=inject(ChangeDetectorRef);

  constructor(private services:Services){}

  newtask={
    name:""
  }

  ngOnInit():void{
    this.loadtask();
    console.log("grbfggbf");
  }
  loadtask() {
    console.log("svfdsv");
    this.services.gettask().subscribe({
      next: (data) =>{
        this.task=data;
        this.cd.detectChanges();
        console.log(this.task)
      }
    });
  }

  addtask(){
    const newtask: todo = {
  id: 0,
  taskName: this.newtask.name,
  datetime: new Date().toISOString(),
  isDone: false
};
    this.services.addtask(newtask).subscribe({
      next:()=>{
        this.loadtask();
      }
    });
    
    console.log("this executed");
  }
}
