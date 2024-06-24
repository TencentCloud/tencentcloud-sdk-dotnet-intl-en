/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrganizationalFunction : AbstractModel
    {
        
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Display Name
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Hierarchical Path
        /// </summary>
        [JsonProperty("LayerPath")]
        public string LayerPath{ get; set; }

        /// <summary>
        /// Parent Hierarchical Path
        /// </summary>
        [JsonProperty("ParentLayerPath")]
        public string ParentLayerPath{ get; set; }

        /// <summary>
        /// Function Type
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Function Classification: Window functions, Aggregation functions, Date functions...
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// Function Category: System functions, Custom Definition functions
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Function Status
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Function DescriptionNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Function Usage
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// Function Parameter Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ParamDesc")]
        public string ParamDesc{ get; set; }

        /// <summary>
        /// Function Return Value Description
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ReturnDesc")]
        public string ReturnDesc{ get; set; }

        /// <summary>
        /// Function Example
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Example")]
        public string Example{ get; set; }

        /// <summary>
        /// Cluster Instance Engine IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClusterIdentifier")]
        public string ClusterIdentifier{ get; set; }

        /// <summary>
        /// Function IDNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FuncId")]
        public string FuncId{ get; set; }

        /// <summary>
        /// Function Class Name
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// Function Resource List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ResourceList")]
        public FunctionVersion[] ResourceList{ get; set; }

        /// <summary>
        /// Operator ID List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OperatorUserIds")]
        public long?[] OperatorUserIds{ get; set; }

        /// <summary>
        /// Public cloud Owner ID list
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerUserIds")]
        public long?[] OwnerUserIds{ get; set; }

        /// <summary>
        /// Database nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Submission failed error message
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubmitErrorMsg")]
        public string SubmitErrorMsg{ get; set; }

        /// <summary>
        /// Pattern nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// Function Command FormatNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CommandFormat")]
        public string CommandFormat{ get; set; }

        /// <summary>
        /// NameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// TimestampNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubmitTimestamp")]
        public string SubmitTimestamp{ get; set; }

        /// <summary>
        /// Function tag
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Operator ID List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OperatorUserIdsStr")]
        public string[] OperatorUserIdsStr{ get; set; }

        /// <summary>
        /// Public Cloud Owner ID List
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OwnerUserIdsStr")]
        public string[] OwnerUserIdsStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "LayerPath", this.LayerPath);
            this.SetParamSimple(map, prefix + "ParentLayerPath", this.ParentLayerPath);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "ParamDesc", this.ParamDesc);
            this.SetParamSimple(map, prefix + "ReturnDesc", this.ReturnDesc);
            this.SetParamSimple(map, prefix + "Example", this.Example);
            this.SetParamSimple(map, prefix + "ClusterIdentifier", this.ClusterIdentifier);
            this.SetParamSimple(map, prefix + "FuncId", this.FuncId);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamArrayObj(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamArraySimple(map, prefix + "OperatorUserIds.", this.OperatorUserIds);
            this.SetParamArraySimple(map, prefix + "OwnerUserIds.", this.OwnerUserIds);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SubmitErrorMsg", this.SubmitErrorMsg);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "CommandFormat", this.CommandFormat);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "SubmitTimestamp", this.SubmitTimestamp);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamArraySimple(map, prefix + "OperatorUserIdsStr.", this.OperatorUserIdsStr);
            this.SetParamArraySimple(map, prefix + "OwnerUserIdsStr.", this.OwnerUserIdsStr);
        }
    }
}

