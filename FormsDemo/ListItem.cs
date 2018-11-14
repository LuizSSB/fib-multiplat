using System;
namespace FormsDemo
{
    public class ListItem
    {
        public string ItemTitle
        {
            get;
            set;
        }

        public string Subtitle {
            get;
            set;
        }

        public string IconName
        {
            get;
            set;
        }
    }

    public class ListSection :
        System.Collections.Generic.List<ListItem> {
        public string Title
        {
            get;
            set;
        }
    }

}
