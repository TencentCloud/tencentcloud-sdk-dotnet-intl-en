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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CLSInfo : AbstractModel
    {
        
        /// <summary>
        /// Log topic operation: Options are create, reuse. 
        /// create: Create a new log topic, using TopicName to create the log topic.
        /// reuse: Use an existing log topic, using TopicId to specify the log topic.
        /// The combination of using an existing log topic while creating a new logset is not allowed.
        /// </summary>
        [JsonProperty("TopicOperation")]
        public string TopicOperation{ get; set; }

        /// <summary>
        /// Logset operation: Options are create, reuse.
        /// create: Create a new logset, using GroupName to create the logset.
        /// reuse: Use an existing logset, using GroupId to specify the logset.
        /// The combination of using an existing log topic while creating a new logset is not allowed.
        /// </summary>
        [JsonProperty("GroupOperation")]
        public string GroupOperation{ get; set; }

        /// <summary>
        /// Log delivery region.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Log topic ID.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Log topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Logset ID.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Logset name.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicOperation", this.TopicOperation);
            this.SetParamSimple(map, prefix + "GroupOperation", this.GroupOperation);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

