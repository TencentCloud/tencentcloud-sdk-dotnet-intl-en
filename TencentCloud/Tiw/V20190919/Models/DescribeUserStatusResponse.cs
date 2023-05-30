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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserStatusResponse : AbstractModel
    {
        
        /// <summary>
        /// AppId of the customer.
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// Specifies whether the whiteboard service of the trial or official edition is activated before.
        /// 
        /// 0: The whiteboard service is not activated.
        /// 1: The whiteboard service is activated.
        /// </summary>
        [JsonProperty("IsTiwUser")]
        public long? IsTiwUser{ get; set; }

        /// <summary>
        /// Specifies whether the interactive class feature of the trial or official edition is activated before.
        /// </summary>
        [JsonProperty("IsSaaSUser")]
        public long? IsSaaSUser{ get; set; }

        /// <summary>
        /// Specifies whether the user uses the offline recording feature of the whiteboard service.
        /// </summary>
        [JsonProperty("IsTiwOfflineRecordUser")]
        public long? IsTiwOfflineRecordUser{ get; set; }

        /// <summary>
        /// Specifies whether the user is authenticated.
        /// </summary>
        [JsonProperty("IsAuthenticated")]
        public long? IsAuthenticated{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "IsTiwUser", this.IsTiwUser);
            this.SetParamSimple(map, prefix + "IsSaaSUser", this.IsSaaSUser);
            this.SetParamSimple(map, prefix + "IsTiwOfflineRecordUser", this.IsTiwOfflineRecordUser);
            this.SetParamSimple(map, prefix + "IsAuthenticated", this.IsAuthenticated);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

