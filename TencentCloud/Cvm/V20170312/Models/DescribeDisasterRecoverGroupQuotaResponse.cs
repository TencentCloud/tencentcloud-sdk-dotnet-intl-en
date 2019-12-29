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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDisasterRecoverGroupQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// The maximum number of placement groups that can be created.
        /// </summary>
        [JsonProperty("GroupQuota")]
        public long? GroupQuota{ get; set; }

        /// <summary>
        /// The number of placement groups that have been created by the current user.
        /// </summary>
        [JsonProperty("CurrentNum")]
        public long? CurrentNum{ get; set; }

        /// <summary>
        /// Quota on instances in a physical-machine-type disaster recovery group.
        /// </summary>
        [JsonProperty("CvmInHostGroupQuota")]
        public long? CvmInHostGroupQuota{ get; set; }

        /// <summary>
        /// Quota on instances in a switch-type disaster recovery group.
        /// </summary>
        [JsonProperty("CvmInSwGroupQuota")]
        public long? CvmInSwGroupQuota{ get; set; }

        /// <summary>
        /// Quota on instances in a rack-type disaster recovery group.
        /// </summary>
        [JsonProperty("CvmInRackGroupQuota")]
        public long? CvmInRackGroupQuota{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupQuota", this.GroupQuota);
            this.SetParamSimple(map, prefix + "CurrentNum", this.CurrentNum);
            this.SetParamSimple(map, prefix + "CvmInHostGroupQuota", this.CvmInHostGroupQuota);
            this.SetParamSimple(map, prefix + "CvmInSwGroupQuota", this.CvmInSwGroupQuota);
            this.SetParamSimple(map, prefix + "CvmInRackGroupQuota", this.CvmInRackGroupQuota);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

