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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Instance status. Valid values:
        /// <li>1: applying</li>
        /// <li>2: running</li>
        /// <li>3: running restrictedly (primary/secondary switching)</li>
        /// <li>4: isolated</li>
        /// <li>5: repossessing</li>
        /// <li>6: repossessed</li>
        /// <li>7: executing task (e.g., backing up or rolling back instance)</li>
        /// <li>8: deactivated</li>
        /// <li>9: scaling out instance</li>
        /// <li>10: migrating instance</li>
        /// <li>11: read-only</li>
        /// <li>12: restarting</li>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Page number. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results per page. Value range: 1-100. Default value: 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// One or more instance IDs in the format of mssql-si2823jyl
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Retrieves billing type. 0: pay-as-you-go
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Unique string-type ID of instance VPC in the format of `vpc-xxx`. If an empty string ("") is passed in, filtering will be made by basic network.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Unique string-type ID of instance subnet in the format of `subnet-xxx`. If an empty string ("") is passed in, filtering will be made by basic network.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// The list of instance private IPs, such as 172.1.0.12
        /// </summary>
        [JsonProperty("VipSet")]
        public string[] VipSet{ get; set; }

        /// <summary>
        /// The list of instance names used for fuzzy match
        /// </summary>
        [JsonProperty("InstanceNameSet")]
        public string[] InstanceNameSet{ get; set; }

        /// <summary>
        /// The list of instance version numbers, such as 2008R2, 2012SP3
        /// </summary>
        [JsonProperty("VersionSet")]
        public string[] VersionSet{ get; set; }

        /// <summary>
        /// Instance availability zone, such as ap-guangzhou-3
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// The list of instance tags
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }

        /// <summary>
        /// Keyword used for fuzzy match, including instance ID, instance name, and instance private IP
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Unique Uid of an instance
        /// </summary>
        [JsonProperty("UidSet")]
        public string[] UidSet{ get; set; }

        /// <summary>
        /// Instance type. HA: high-availability instance; RO: read-only instance; SI: basic edition instance; BI: business intelligence service instance; cvmHA: dual-server high-availability instance with cloud disk; cvmRO: read-only instance with cloud disk; MultiHA: multi-node instance; cvmMultiHA: multi-node instance with cloud disk.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Pagination query method. offset - pagination query by offset; pageNumber - pagination query by number of pages. The default value is pageNumber.
        /// </summary>
        [JsonProperty("PaginationType")]
        public string PaginationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArraySimple(map, prefix + "VipSet.", this.VipSet);
            this.SetParamArraySimple(map, prefix + "InstanceNameSet.", this.InstanceNameSet);
            this.SetParamArraySimple(map, prefix + "VersionSet.", this.VersionSet);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "UidSet.", this.UidSet);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "PaginationType", this.PaginationType);
        }
    }
}

