@media print {
    /* General Page Setup */
    body {
        margin: 10mm; /* Adjust page margins */
    }

    /* Ensure tables fit within the A4 printable area */
    table {
        width: 100%;
        border-collapse: collapse;
        table-layout: fixed; /* Ensures columns are sized properly */
        page-break-inside: avoid; /* Prevent tables from breaking across pages */
    }

    /* Table headers */
    table th {
        background-color: #007bff; /* Bootstrap primary color */
        color: white;
        text-align: left;
        padding: 8px;
        border: 1px solid #dee2e6; /* Table border */
        font-size: 0.9rem; /* Smaller text to fit content */
        word-wrap: break-word; /* Allow headers to wrap text */
    }

    /* Table cells */
    table td {
        padding: 8px;
        border: 1px solid #dee2e6;
        font-size: 0.9rem; /* Smaller text */
        word-wrap: break-word; /* Prevent content from overflowing cells */
        overflow: hidden; /* Hide any overflowing content */
        text-overflow: ellipsis; /* Optional: Add ellipsis for long text */
    }

    /* Handle nested tables */
    table table {
        margin: 0;
        padding: 0;
        width: 100%;
        border: 1px solid #ced4da;
    }

    table table th, table table td {
        font-size: 0.8rem; /* Reduce font size for nested tables */
        padding: 6px;
        border: 1px solid #dee2e6;
        word-wrap: break-word; /* Ensure nested cells wrap text */
    }

    /* Responsive table wrapper */
    .table-responsive {
        overflow-x: auto;
        page-break-inside: avoid;
    }

    /* Prevent row breaking */
    tr {
        page-break-inside: avoid;
    }

    /* Optional: Footer/header to track page numbers */
    @page {
        size: A4;
        margin: 10mm;
    }

    header, footer {
        display: none;
    }

    /* Font scaling for large content */
    body, td, th {
        font-size: 12px; /* Adjust as needed */
    }

    /* Scale down content to fit within the page */
    .content {
        transform: scale(0.95); /* Slightly reduce the scale to fit more content */
        transform-origin: top left;
    }
}
