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

    public class ActionTimer : AbstractModel
    {
        
        /// <summary>
        /// Timer action. Valid value: `TerminateInstances`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimerAction")]
        public string TimerAction{ get; set; }

        /// <summary>
        /// Action time, which follows the ISO8601 standard and uses UTC time. It must be 5 minutes later than the current time. Format: YYYY-MM-DDThh:mm:ssZ. For example: 2018-05-29T11:26:40Z.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// Extended data
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// Timer ID.
        /// </summary>
        [JsonProperty("ActionTimerId")]
        public string ActionTimerId{ get; set; }

        /// <summary>
        /// Timer status. Valid values:
        /// 
        /// UNDO: Not triggered.
        /// DOING: Triggering.
        /// DONE: Triggered already.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Instance ID corresponding to a timer.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerAction", this.TimerAction);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "ActionTimerId", this.ActionTimerId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

