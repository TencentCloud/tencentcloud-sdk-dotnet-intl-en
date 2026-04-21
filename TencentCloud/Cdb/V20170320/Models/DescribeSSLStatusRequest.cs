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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, which can be obtained through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872) API. Note: Either the instance ID or read-only group ID parameter needs to be specified. To query the enabling status of the SSL for two-node or three-node instances, you need to specify the instance ID parameter. Single-node (cloud disk) and Cluster Edition instances do not support enabling SSL; thus, queries are not supported.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Read-only group ID, which can be obtained through the [DescribeRoGroups](https://www.tencentcloud.com/document/product/236/35704) API. Note: Either the instance ID or read-only group ID parameter needs to be specified. To query the enabling status of the SSL for read-only instances or groups, you need to specify the RoGroupId parameter. Note that the value should be the read-only group ID. Single-node (cloud disk) and Cluster Edition instances do not support enabling SSL; thus, queries are not supported.
        /// </summary>
        [JsonProperty("RoGroupId")]
        public string RoGroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RoGroupId", this.RoGroupId);
        }
    }
}

