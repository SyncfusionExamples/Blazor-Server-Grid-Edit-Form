# Blazor Server DataGrid CRUD Editing with EditForm Navigation

## Overview

This sample demonstrates how to perform CRUD operations in a Syncfusion Blazor DataGrid by integrating Blazor `EditForm` components into the editing workflow. Instead of editing records directly inside the Grid, records are edited through a dedicated page that is reached through navigation, providing an experience similar to MVC scaffolding patterns. The sample shows how a Blazor Server application can combine DataGrid data presentation with form-based editing to separate record management from the main Grid view.

## Key Features

- Uses the Syncfusion Blazor DataGrid to display and manage records.
- Demonstrates Create, Read, Update, and Delete (CRUD) operations within a Blazor Server application.
- Uses Blazor `EditForm` components for record editing instead of inline Grid editing.
- Demonstrates navigation-based editing where a Grid action redirects users to a dedicated edit page.
- Shows how Grid-displayed records can be updated through a separate form workflow and reflected back in the DataGrid.
- Provides a reference implementation for applications that require page-based editing experiences rather than modal dialogs or inline editors.

## Prerequisites

* Visual Studio 2022

## How to Run the Project

1. Checkout this repository to a location on your local machine.
2. Open `GridEditFormSample.sln` using Visual Studio 2022.
3. Restore the NuGet packages by rebuilding the solution.
4. Build the application to ensure all dependencies are resolved successfully.
5. Run the project.
6. Navigate to the page that hosts the Syncfusion DataGrid sample.
7. Use the available CRUD actions and edit a record through the dedicated EditForm page to review the navigation-based editing workflow.

## Project Structure

- `Pages/` — contains the Razor pages that host the Syncfusion DataGrid and the EditForm-based editing experience.
- `Data/` — contains the sample data model and data access logic used by the Grid and EditForm workflow.
- `Shared/` — contains shared layout and application components consumed by the sample pages.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to DataGrid editing, see https://help.syncfusion.com/grid-sdk/blazor/data-grid/editing

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.