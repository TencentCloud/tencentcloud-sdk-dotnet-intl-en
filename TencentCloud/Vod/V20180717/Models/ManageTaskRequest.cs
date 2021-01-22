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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManageTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Video processing task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Operation type. Valid value:
        /// <li>Abort: terminate a task. You can only terminate initiated tasks in `WAITING` status.</li>
        /// </summary>
        [JsonProperty("OperationType")]
        public string OperationType{ get; set; }

        /// <summary>
        /// VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "OperationType", this.OperationType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

