/*
Model definition for an entity. 

Database......{{_DatabaseName}}
Table.........{{_TableName}}

Generated on..{{_datetime}}
Template......{{_template}}
Schema........{{_schema}}
*/

namespace DataAccess.Models
{
    public class {{TableName}}Model
    {
        {% for column in columns %}
        public {{column.CSType}} {{column.ColumnName}} {get;set;}
        {% endfor %}
    }
}