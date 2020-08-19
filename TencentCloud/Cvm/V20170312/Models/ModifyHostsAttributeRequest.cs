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

    public class ModifyHostsAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// CDH instance ID(s).
        /// </summary>
        [JsonProperty("HostIds")]
        public string[] HostIds{ get; set; }

        /// <summary>
        /// CDH instance name to be displayed. You can specify any name you like, but its length cannot exceed 60 characters.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Auto renewal flag. Valid values: <br><li>NOTIFY_AND_AUTO_RENEW: notify upon expiration and renew automatically <br><li>NOTIFY_AND_MANUAL_RENEW: notify upon expiration but do not renew automatically <br><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: neither notify upon expiration nor renew automatically <br><br>If this parameter is specified as NOTIFY_AND_AUTO_RENEW, the instance will be automatically renewed on a monthly basis if the account balance is sufficient.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Project ID. You can create a project by using the [AddProject](https://intl.cloud.tencent.com/doc/api/403/4398?from_cn_redirect=1) API and obtain its ID from the response parameter `projectId` of the [`DescribeProject`](https://intl.cloud.tencent.com/document/product/378/4400?from_cn_redirect=1) API. Subsequently, the project ID can be used to filter results when you query instances by calling the [DescribeHosts](https://intl.cloud.tencent.com/document/api/213/16474?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HostIds.", this.HostIds);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

