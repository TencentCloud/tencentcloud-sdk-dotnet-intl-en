/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDatasourceRequest : AbstractModel
    {
        
        /// <summary>
        /// HOST
        /// </summary>
        [JsonProperty("DbHost")]
        public string DbHost{ get; set; }

        /// <summary>
        /// Port.
        /// </summary>
        [JsonProperty("DbPort")]
        public ulong? DbPort{ get; set; }

        /// <summary>
        /// The backend provides dictionaries: domain type. 1. Tencent Cloud, 2. local.
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Drive.
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// Database encoding.
        /// </summary>
        [JsonProperty("Charset")]
        public string Charset{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("DbUser")]
        public string DbUser{ get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty("DbPwd")]
        public string DbPwd{ get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// Database alias.
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Catalog value.
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// Third-party data source identifier.
        /// </summary>
        [JsonProperty("DataOrigin")]
        public string DataOrigin{ get; set; }

        /// <summary>
        /// Third-party project ID.
        /// </summary>
        [JsonProperty("DataOriginProjectId")]
        public string DataOriginProjectId{ get; set; }

        /// <summary>
        /// Third-party data source ID.
        /// </summary>
        [JsonProperty("DataOriginDatasourceId")]
        public string DataOriginDatasourceId{ get; set; }

        /// <summary>
        /// Extension parameter.
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }

        /// <summary>
        /// Unified identifier of the Tencent Cloud VPC.
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// VPC IP address.
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// VPC port.
        /// </summary>
        [JsonProperty("Vport")]
        public string Vport{ get; set; }

        /// <summary>
        /// Tencent Cloud VPC identifier.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Operation permission limitation.
        /// </summary>
        [JsonProperty("OperationAuthLimit")]
        public string[] OperationAuthLimit{ get; set; }

        /// <summary>
        /// Enables VPC.
        /// </summary>
        [JsonProperty("UseVPC")]
        public bool? UseVPC{ get; set; }

        /// <summary>
        /// Region.
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbHost", this.DbHost);
            this.SetParamSimple(map, prefix + "DbPort", this.DbPort);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "DbUser", this.DbUser);
            this.SetParamSimple(map, prefix + "DbPwd", this.DbPwd);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "DataOrigin", this.DataOrigin);
            this.SetParamSimple(map, prefix + "DataOriginProjectId", this.DataOriginProjectId);
            this.SetParamSimple(map, prefix + "DataOriginDatasourceId", this.DataOriginDatasourceId);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "OperationAuthLimit.", this.OperationAuthLimit);
            this.SetParamSimple(map, prefix + "UseVPC", this.UseVPC);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

