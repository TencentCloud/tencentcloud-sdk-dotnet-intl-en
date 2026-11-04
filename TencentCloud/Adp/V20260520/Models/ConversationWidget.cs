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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConversationWidget : AbstractModel
    {
        
        /// <summary>
        /// <p>Base64-encoded original widget data</p>
        /// </summary>
        [JsonProperty("EncodedWidget")]
        public string EncodedWidget{ get; set; }

        /// <summary>
        /// <p>payload from the user's last submission</p>
        /// </summary>
        [JsonProperty("Payload")]
        public string Payload{ get; set; }

        /// <summary>
        /// <p>Location of the widget in the text</p>
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }

        /// <summary>
        /// <p>widget status JSON data</p>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>widget view data</p>
        /// </summary>
        [JsonProperty("View")]
        public string View{ get; set; }

        /// <summary>
        /// <p>component_ID</p>
        /// </summary>
        [JsonProperty("WidgetId")]
        public string WidgetId{ get; set; }

        /// <summary>
        /// <p>Component operation ID</p>
        /// </summary>
        [JsonProperty("WidgetRunId")]
        public string WidgetRunId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EncodedWidget", this.EncodedWidget);
            this.SetParamSimple(map, prefix + "Payload", this.Payload);
            this.SetParamSimple(map, prefix + "Position", this.Position);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "View", this.View);
            this.SetParamSimple(map, prefix + "WidgetId", this.WidgetId);
            this.SetParamSimple(map, prefix + "WidgetRunId", this.WidgetRunId);
        }
    }
}

