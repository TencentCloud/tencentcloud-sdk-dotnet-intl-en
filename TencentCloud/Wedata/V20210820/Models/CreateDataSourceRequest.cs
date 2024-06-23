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

    public class CreateDataSourceRequest : AbstractModel
    {
        
        /// <summary>
        /// Data Source Name, cannot be empty under the same SpaceName
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Data Source Category: Binding Engine, Binding Database
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// Data Source Type: enumerated values
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("OwnerProjectId")]
        public string OwnerProjectId{ get; set; }

        /// <summary>
        /// Project Name
        /// </summary>
        [JsonProperty("OwnerProjectName")]
        public string OwnerProjectName{ get; set; }

        /// <summary>
        /// Project Name (Chinese)
        /// </summary>
        [JsonProperty("OwnerProjectIdent")]
        public string OwnerProjectIdent{ get; set; }

        /// <summary>
        /// Configuration Information Extension of Business Data Source
        /// </summary>
        [JsonProperty("BizParams")]
        public string BizParams{ get; set; }

        /// <summary>
        /// Data source configuration information, stored as JSON KV. The KV storage information varies according to the data source type
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// Data source description information
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Data Source Display Name, for visual inspection
        /// </summary>
        [JsonProperty("Display")]
        public string Display{ get; set; }

        /// <summary>
        /// If the data source list is bound to a database, then it is the database name
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Instance ID of the data source engine, e.g., CDB Instance ID
        /// </summary>
        [JsonProperty("Instance")]
        public string Instance{ get; set; }

        /// <summary>
        /// Visibility of the data source, where 1 is visible and 0 is not visible. Default is 1
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Name of the business space to which the data source belongs
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Collection Status
        /// </summary>
        [JsonProperty("Collect")]
        public string Collect{ get; set; }

        /// <summary>
        /// COS Bucket Information
        /// </summary>
        [JsonProperty("COSBucket")]
        public string COSBucket{ get; set; }

        /// <summary>
        /// cos region
        /// </summary>
        [JsonProperty("COSRegion")]
        public string COSRegion{ get; set; }

        /// <summary>
        /// Connection Test Result
        /// </summary>
        [JsonProperty("ConnectResult")]
        public string ConnectResult{ get; set; }

        /// <summary>
        /// Development Environment Data Source Configuration
        /// </summary>
        [JsonProperty("DevelopmentParams")]
        public string DevelopmentParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OwnerProjectId", this.OwnerProjectId);
            this.SetParamSimple(map, prefix + "OwnerProjectName", this.OwnerProjectName);
            this.SetParamSimple(map, prefix + "OwnerProjectIdent", this.OwnerProjectIdent);
            this.SetParamSimple(map, prefix + "BizParams", this.BizParams);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Display", this.Display);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Instance", this.Instance);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Collect", this.Collect);
            this.SetParamSimple(map, prefix + "COSBucket", this.COSBucket);
            this.SetParamSimple(map, prefix + "COSRegion", this.COSRegion);
            this.SetParamSimple(map, prefix + "ConnectResult", this.ConnectResult);
            this.SetParamSimple(map, prefix + "DevelopmentParams", this.DevelopmentParams);
        }
    }
}

