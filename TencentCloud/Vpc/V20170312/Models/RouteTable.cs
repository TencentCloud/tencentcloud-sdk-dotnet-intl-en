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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RouteTable : AbstractModel
    {
        
        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// The route table instance ID, such as `rtb-azd4dt1c`.
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// Route table name.
        /// </summary>
        [JsonProperty("RouteTableName")]
        public string RouteTableName{ get; set; }

        /// <summary>
        /// The association relationships of the route table.
        /// </summary>
        [JsonProperty("AssociationSet")]
        public RouteTableAssociation[] AssociationSet{ get; set; }

        /// <summary>
        /// IPv4 routing policy set.
        /// </summary>
        [JsonProperty("RouteSet")]
        public Route[] RouteSet{ get; set; }

        /// <summary>
        /// Whether it is the default route table.
        /// </summary>
        [JsonProperty("Main")]
        public bool? Main{ get; set; }

        /// <summary>
        /// Creation Time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Tag key-value pairs.
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// Whether the local route is published to CCN.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LocalCidrForCcn")]
        public CidrForCcn[] LocalCidrForCcn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamSimple(map, prefix + "RouteTableName", this.RouteTableName);
            this.SetParamArrayObj(map, prefix + "AssociationSet.", this.AssociationSet);
            this.SetParamArrayObj(map, prefix + "RouteSet.", this.RouteSet);
            this.SetParamSimple(map, prefix + "Main", this.Main);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArrayObj(map, prefix + "LocalCidrForCcn.", this.LocalCidrForCcn);
        }
    }
}

