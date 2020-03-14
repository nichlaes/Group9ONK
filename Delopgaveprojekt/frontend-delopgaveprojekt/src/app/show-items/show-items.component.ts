import { Component, OnInit } from '@angular/core';
import { ToolService } from '../services/tool.service';
import { ToolBoxService } from '../services/toolbox.service';
import { CraftsmanService } from '../services/craftsman.service';
import { Tool } from '../models/tool.model';
import { ToolBox } from '../models/toolbox.model';
import { Craftsman } from '../models/craftsman.model';

@Component({
  selector: 'app-show-items',
  templateUrl: './show-items.component.html',
  styleUrls: ['./show-items.component.css']
})
export class ShowItemsComponent implements OnInit {

  tools: Tool[] = [<Tool>{ VTId: 1 }, <Tool>{ VTId: 2 }, <Tool>{ VTId: 3 }];
  toolboxes: ToolBox[] = [<ToolBox>{ VTKId: 1 }, <ToolBox>{ VTKId: 2 }, <ToolBox>{ VTKId: 3 }];
  craftsmen: Craftsman[] = [<Craftsman>{ HaandvaerkerId: 1 }, <Craftsman>{ HaandvaerkerId: 2 }, <Craftsman>{ HaandvaerkerId: 3 }];

  constructor(private toolService: ToolService, private toolboxService: ToolBoxService, private craftsmanService: CraftsmanService) { }

  ngOnInit(): void {
    //this.toolService.getTools().subscribe(res => this.tools = res);
    //this.toolboxService.getToolBoxes().subscribe(res => this.toolboxes = res);
    //this.craftsmanService.getCraftsmen().subscribe(res => this.craftsmen = res);

  }

}
