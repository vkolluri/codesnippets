/* General table styles */
table {
    width: 100%;
    border-collapse: collapse;
    box-sizing: border-box;
    page-break-inside: avoid; /* Prevent tables from breaking across pages */
}

/* Table headers */
table th {
    background-color: #007bff; /* Bootstrap primary color */
    color: white;
    text-align: left;
    padding: 10px;
    border: 1px solid #dee2e6; /* Bootstrap table border color */
}

/* Table cells */
table td {
    padding: 10px;
    border: 1px solid #dee2e6; /* Ensure borders are visible */
    white-space: nowrap; /* Prevent text wrapping */
    overflow: hidden; /* Ensure no content overlaps */
    text-overflow: ellipsis; /* Add ellipsis for long text */
}

/* Nested tables */
table table {
    margin: 0; /* Remove any additional margins for nested tables */
    padding: 0;
    width: 100%;
    border: 1px solid #ced4da; /* Lighter border for nested tables */
}

table table th, table table td {
    font-size: 0.9rem; /* Smaller font for nested tables */
    padding: 8px; /* Slightly smaller padding */
    border: 1px solid #dee2e6;
}

/* Responsive table */
.table-responsive {
    overflow-x: auto;
    page-break-inside: avoid; /* Ensure responsive wrapper does not break pages */
}

/* Avoid page breaks inside rows */
table tr {
    page-break-inside: avoid; /* Prevent rows from breaking across pages */
}

/* Avoid overlapping content */
table td, table th {
    vertical-align: top; /* Ensure proper alignment to prevent overlap */
}

/* Optional: Styling for table row headers */
.table-header-row {
    background-color: #6c757d; /* Secondary Bootstrap color */
    color: white;
    font-weight: bold;
}

/* Prevent nested table collapsing */
.nested-table-wrapper {
    padding: 10px;
    box-sizing: border-box;
}
