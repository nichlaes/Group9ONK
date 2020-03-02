import { Component, OnInit, Input } from '@angular/core';
import { Tool } from '../models/tool.model';

@Component({
  selector: 'app-create-tool',
  templateUrl: './create-tool.component.html',
  styleUrls: ['./create-tool.component.css']
})
export class CreateToolComponent implements OnInit {

  @Input() model: Tool;

  constructor() {
    if (this.model == null)
      this.model = new Tool(0, null, null, null, null, null, null);

  }

  ngOnInit(): void {
  }

}
