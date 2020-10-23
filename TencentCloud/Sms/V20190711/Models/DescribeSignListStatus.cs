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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSignListStatus : AbstractModel
    {
        
        /// <summary>
        /// Signature ID
        /// </summary>
        [JsonProperty("SignId")]
        public ulong? SignId{ get; set; }

        /// <summary>
        /// Whether it is Global SMS. Valid values:
        /// 0: Mainland China SMS.
        /// 1: Global SMS
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// Signature application status. Valid values:
        /// 0: approved.
        /// -1: rejected or failed.
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// Review reply, i.e., response given by the reviewer, which is usually the reason for rejection.
        /// </summary>
        [JsonProperty("ReviewReply")]
        public string ReviewReply{ get; set; }

        /// <summary>
        /// Signature name.
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// Application submission time in the format of UNIX timestamp in seconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "ReviewReply", this.ReviewReply);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

