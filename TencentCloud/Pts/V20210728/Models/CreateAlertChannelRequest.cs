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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAlertChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// The NoticeId of alarm notification template in the monitor service, can be obtained from the Id field in the response of the DescribeAlarmNotices API of the monitor service's cloud API. (In the input parameters of the CreateAlertChannel API, either AMPConsumerId or NoticeId can be used to identify an alarm notification template.)
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }

        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// The AMPConsumerId of alarm notification template for monitor service, can be obtained from the AMPConsumerId field in the response of the DescribeAlarmNotices API of the monitor service's cloud API. (In the input parameters of the CreateAlertChannel API, either AMPConsumerId or Noticeid can be used to identify an alarm notification template.)
        /// </summary>
        [JsonProperty("AMPConsumerId")]
        public string AMPConsumerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "AMPConsumerId", this.AMPConsumerId);
        }
    }
}

