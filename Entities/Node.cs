using System;

namespace Sca.Api.Entities
{
    public class NodeType : BaseEntity
    {
        public string Title { get; set}
        public int TreeLevel { get; set}
    }

    public class Node : BaseEntity
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int ViewOrder { get; set; }
        public string AppObject { get; set; }
        public NodeType NodeType { get; set; }
    }

    public class TreeNode : BaseEntity
    {
        public int? ParentId { get; set; }

        public int NodeId { get; set; }

        public string Code { get; set; }

        public bool IsActive { get; set; }

        public int? ViewOrder { get; set; }

        public string AppObject { get; set; }
    }
}