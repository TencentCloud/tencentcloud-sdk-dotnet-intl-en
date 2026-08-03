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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRuleItem : AbstractModel
    {
        
        /// <summary>
        /// Rule direction: 1 means inbound, 0 means outbound; other integers or omitted values result in verification failure. Direction also determines the available combinations of SourceType, TargetType, Scope, and Protocol.
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// Rule order, required. Pass -1 to append to the end of the current direction; a positive serial number indicates insertion at the corresponding position and postponement of subsequent rules; treat 0 as 1, other negative numbers and out-of-scope values should not be used. When a new request contains multiple rules, Direction must be the same; pass all -1 for appending, pass consecutive incremental positive serial numbers in request order for insertion. A modify request accepts only one rule.
        /// </summary>
        [JsonProperty("OrderIndex")]
        public long? OrderIndex{ get; set; }

        /// <summary>
        /// Destination port. Ignore this field and set it to an empty string when Protocol is ICMP. For other protocols, you must provide a parse string. You can enter a positive integer single port or a "start/end" range separated with commas. The starting value must not be larger than the end value. -1/-1 indicates all ports. FTP only accepts one positive integer. For domain or domain name template targets within the side or all scope, only -1/-1 or 0/65535 are accepted.
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// Protocol, case-insensitive parsing. Layer-4 values TCP, UDP, ICMP, ICMPV6, ANY are normalized to uppercase. Application-layer values HTTP, HTTPS, HTTP/HTTPS, SMTP, SMTPS, SMTP/SMTPS, FTP, DNS, TLS/SSL and aliases domain, TLS, SSL are normalized to corresponding standard values. ANY means no protocol limitation, not an empty Protocol. It belongs to both parseable Layer-4 protocols and application protocols. domain, TLS, SSL are all normalized to TLS/SSL. The target for domain or domain name template accepts the above application-layer protocols and ANY, but does not accept FTP and other Layer-4 protocols. dnsparse and domainiptwoverify only accept TCP or UDP and only support serial. Other targets in the public cloud environment do not accept application-layer protocols outside of FTP and ANY. Under the side or all scope, inbound only accepts TCP, outbound only accepts TCP, HTTP/HTTPS, or TLS/SSL. When DNS is used for a non-domain target and the target is not *, the destination content must also be a rule list of valid non-IP domain names. When using a protocol port template, each group of protocol and port in the template also executes these integration validations.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Traffic processing actions are case-insensitive. accept means allow, drop means deny, and log means observe. isolateinaccept means allow access to allowlisted traffic for isolated assets, isolateindrop means block access to other traffic for isolated assets, isolateoutaccept means allow isolated assets to access allowlisted targets, and isolateoutdrop means block isolated assets from accessing other targets. drop and its deny alias also verify whether the current account has Internet boundary blocking capability.
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// Access the source content. For ip or net, use a valid IP/CIDR list, with a maximum of 10 items in a regular list. For template, use a parseable address template identifier of the current account. When Direction=0, use the corresponding resource identifier for instance, group, and tag. Among them, the instance must be resolvable to a public IP, and the tag must exist with the format {"Key":"tag key","Value":"tag value"}. When Direction=1, use a CSV of region codes for location, which must pass the verification of the new regional rules capability of the current account. For vendor, use a CSV of tencent, aliyun, aws, huawei, azure, or all. location and vendor are converted to region or manufacturer matchmaking information when saved.
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// Access source type, case-insensitive parsing. net and ip both indicate IP/CIDR, template refers to address template, instance refers to asset instance, group refers to asset group, tag refers to resource tag, location refers to region, vendor refers to cloud service provider. Direction=1 accepts ip, net, template, location, vendor; Direction=0 accepts ip, net, template, instance, group, tag. ip and net are handled as the same type.
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// Access the destination content. For ip or net, use a valid IP/CIDR list. For domain, use a valid IP, standard domain name, or wildcard domain name list, and also accept a single *. The regular list supports up to 10 items, and wildcard domain names support up to 5 levels. When domain is used with the DNS protocol, IP is not accepted. For dnsparse, use a single valid domain name, wildcard domain name, or an mb_ domain name template that can be resolved by the current account. For domainiptwoverify, use a single valid domain name without wildcards or such a template. Both do not accept a single *, IP, comma-separated list, or wildcard domain names within the segment. For serial domain segments with wildcards and domainiptwoverify templates, the current environment must support the corresponding capacity. For template, use the address template identifier that can be resolved by the current account. For Direction=1, instance, group, and tag use the corresponding resource identifiers. The instance must be resolvable to a public network IP, and the tag must exist with the format {"Key":"tag key","Value":"tag value"}. For Direction=0, location uses region code CSV, and vendor uses CSV of tencent, aliyun, aws, huawei, azure, or all. The standardized content has a maximum length of 1023.
        /// </summary>
        [JsonProperty("TargetContent")]
        public string TargetContent{ get; set; }

        /// <summary>
        /// Access purpose type. Case-insensitive parsing. net and ip both indicate IP/CIDR, template indicates address template, instance indicates asset instance, group indicates asset group, tag indicates resource tag, location indicates region, vendor indicates cloud service provider, domain indicates FQDN matching (content can also be IP or *), dnsparse indicates loose matching: Host/SNI matches the domain name, or the destination IP belongs to the IP range of the current DNS resolution result of that domain name, hit if any condition is met; domainiptwoverify indicates strict matching: the above two conditions require simultaneous satisfaction. Direction=1 accepts ip, net, template, domain, instance, group, tag; Direction=0 accepts ip, net, template, domain, dnsparse, domainiptwoverify, location, or vendor.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// Rule description, no more than 100 characters. When projects are added, save the requested value; when modified, replace fully, do not inherit old values.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Enable status. Non-empty values accept the string true or false in a case-insensitive manner and are normalized to enable or disable. When omitted or an empty string is input, the default enabled configuration for access control of the current account is read. If this configuration is unavailable, it is enabled by default. Existing rules are replaced without inheriting old values.
        /// </summary>
        [JsonProperty("Enable")]
        public string Enable{ get; set; }

        /// <summary>
        /// Associated alarm or source event ID. When projects are added, omit or input an empty string to indicate not associated. When modifying, import the rules[].log_id returned by DescribeCfwRules as is. If not returned, omit or input an empty string. The old value is not automatically inherited during replacement. When From=batch_import_cover, a non-empty value is also reused as the string literal identification for the rule after overwrite import.
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// Protocol port template ID. Omit or input an empty string to indicate no template is used. If not empty, it must point to an existing template in the current account with the content format "protocol:port", otherwise the request fails. The protocol and port in the template must meet the integration restrictions of Direction, TargetType, and Scope. Protocol and Port must still comply with their respective field rules, but are not required to be fixed as ANY, -1/-1, or serial.
        /// </summary>
        [JsonProperty("ParamTemplateId")]
        public string ParamTemplateId{ get; set; }

        /// <summary>
        /// Rule source: 0 means General rule, 2 means isolated asset outgoing access rule. It can be omitted when projects are added, and omitted values are handled as 0. Only 0 or 2 are accepted for explicit input and modification, and the original rule value should be imported during modification.
        /// </summary>
        [JsonProperty("RuleSource")]
        public long? RuleSource{ get; set; }

        /// <summary>
        /// Effective scope. Case insensitivity: serial means only Internet boundary serial firewall, side means only Internet boundary bypass firewall, all means acting on both serial and bypass firewalls simultaneously. Omitted, empty string, or other values will result in verification failure. The international site environment will normalize valid user-submitted input to serial. For linkage restrictions on protocol, port, destination type, and protocol port templates, refer to Protocol, Port, and ParamTemplateId.
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// Rule numeric value ID. Ordinary new additions, user-specified location additions, and batch import ignore this field; positive integer ID is usable when From=batch_import_cover; must provide an existing and modifiable positive integer ID of the current account for modification, used for locating and fully replacing the original rule, omitted, non-positive integer, or non-existing IDs cause request failure.
        /// </summary>
        [JsonProperty("Uuid")]
        public long? Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetContent", this.TargetContent);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "ParamTemplateId", this.ParamTemplateId);
            this.SetParamSimple(map, prefix + "RuleSource", this.RuleSource);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

