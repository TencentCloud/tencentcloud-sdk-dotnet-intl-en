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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackMigratingTopicStageRequest : AbstractModel
    {
        
        /// <summary>
        /// Task ID. It can be obtained from [SmoothMigrationTaskItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#SmoothMigrationTaskItem) returned by the API [DescribeSmoothMigrationTaskList](https://www.tencentcloud.comom/document/api/1493/119997?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Topic name. It can be obtained from [MigratingTopic](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#MigratingTopic) returned by the API [DescribeMigratingTopicList](https://www.tencentcloud.comom/document/api/1493/118007?from_cn_redirect=1) in Data Type.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Namespace. This parameter is valid only for migration to a 4.x cluster. The namespace can be obtained from [MigratingTopic](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#MigratingTopic) returned by the API [DescribeMigratingTopicList](https://www.tencentcloud.comom/document/api/1493/118007?from_cn_redirect=1) in Data Type.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
        }
    }
}

