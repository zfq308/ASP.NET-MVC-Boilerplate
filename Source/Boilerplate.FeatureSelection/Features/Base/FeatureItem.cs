﻿namespace Boilerplate.FeatureSelection.Features
{
    using Framework.ComponentModel;

    public class FeatureItem : NotifyPropertyChanges, IFeatureItem
    {
        private readonly string description;
        private readonly string icon;
        private readonly string id;
        private readonly bool isContributionWanted;
        private readonly int order;
        private readonly string title;

        private bool isSelected;

        public FeatureItem(string id, string title, string description, int order, string icon = null, bool isContributionWanted = false)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.icon = icon;
            this.order = order;
            this.isContributionWanted = isContributionWanted;
        }

        public string CommentName
        {
            get { return string.Format($"{this.Feature.Id}-{this.Id}"); }
        }

        public string Description
        {
            get { return this.description; }
        }

        public IFeature Feature
        {
            get;
            internal set;
        }

        public string Icon
        {
            get { return this.icon; }
        }

        public string Id
        {
            get { return this.id; }
        }

        public bool IsContributionWanted
        {
            get { return this.isContributionWanted; }
        }

        public bool IsSelected
        {
            get { return this.isSelected; }
            set { this.SetProperty(ref this.isSelected, value); }
        }

        public int Order
        {
            get { return this.order; }
        }

        public string Title
        {
            get { return this.title; }
        }

        public override string ToString()
        {
            return string.Format($"{this.Title} - {this.IsSelected}");
        }
    }
}
