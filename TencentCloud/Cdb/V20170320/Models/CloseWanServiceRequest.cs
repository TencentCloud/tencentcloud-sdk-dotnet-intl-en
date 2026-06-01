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

    public class CloseWanServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID, in the format such as cdb-c1nl9rpv. This matches the instance ID displayed on the TencentDB console. Use the query instance list API (https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1) to obtain it, with its value being the InstanceId field in the output parameter. Input the read-only group ID to disable public network access for the read-only group.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// When updating the read-only group of a cloud disk edition instance, specify the instance ID in InstanceId and this parameter to indicate the operation is for the read-only group. If you perform the operation on the read-write node, this parameter is not required.
        /// </summary>
        [JsonProperty("OpResourceId")]
        public string OpResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OpResourceId", this.OpResourceId);
        }
    }
}

