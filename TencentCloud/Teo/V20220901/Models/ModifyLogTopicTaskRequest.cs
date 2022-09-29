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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLogTopicTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Region of the logset.
        /// </summary>
        [JsonProperty("LogSetRegion")]
        public string LogSetRegion{ get; set; }

        /// <summary>
        /// ID of the logset.
        /// </summary>
        [JsonProperty("LogSetId")]
        public string LogSetId{ get; set; }

        /// <summary>
        /// ID of the log topic.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Type of the shipping entity. Values:
        /// <li>`domain`: L7 acceleration logs;</li>
        /// <li>`application`: L4 acceleration logs;</li>
        /// <li>`web-rateLiming`: Rate limiting logs;</li>
        /// <li>`web-attack`: Web security logs;</li>
        /// <li>`web-rule`: Custom rule logs;</li>
        /// <li>`web-bot`: Bot management logs.</li>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// Name of the shipping task.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// The new topic name. If you do not specify this field, no changes will be made.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// The new logset name.
        /// </summary>
        [JsonProperty("LogSetName")]
        public string LogSetName{ get; set; }

        /// <summary>
        /// The retention period of the updated logset.
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// List of shipping entities to be deleted.
        /// </summary>
        [JsonProperty("DropEntityList")]
        public string[] DropEntityList{ get; set; }

        /// <summary>
        /// List of shipping entities to be added.
        /// </summary>
        [JsonProperty("AddedEntityList")]
        public string[] AddedEntityList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "LogSetRegion", this.LogSetRegion);
            this.SetParamSimple(map, prefix + "LogSetId", this.LogSetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "LogSetName", this.LogSetName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamArraySimple(map, prefix + "DropEntityList.", this.DropEntityList);
            this.SetParamArraySimple(map, prefix + "AddedEntityList.", this.AddedEntityList);
        }
    }
}

