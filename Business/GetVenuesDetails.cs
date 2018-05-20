using FoursquareSampleApp.Business.GetVenuesDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoursquareSampleApp.Business.GetVenuesDetails
{

    public class Meta
    {
        public int code { get; set; }
        public string requestId { get; set; }
    }

    public class Contact
    {
        public string phone { get; set; }
        public string formattedPhone { get; set; }
    }

    public class LabeledLatLng
    {
        public string label { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Location
    {
        public string address { get; set; }
        public string crossStreet { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public List<LabeledLatLng> labeledLatLngs { get; set; }
        public string postalCode { get; set; }
        public string cc { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public List<string> formattedAddress { get; set; }
    }

    public class Icon
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public Icon icon { get; set; }
        public bool primary { get; set; }
    }

    public class Stats
    {
        public int tipCount { get; set; }
    }

    public class Group
    {
        public string type { get; set; }
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Likes
    {
        public int count { get; set; }
        public List<Group> groups { get; set; }
        public string summary { get; set; }
    }

    public class BeenHere
    {
        public int count { get; set; }
        public int unconfirmedCount { get; set; }
        public bool marked { get; set; }
        public int lastCheckinExpiredAt { get; set; }
    }

    public class Specials
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Source
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Photo
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo photo { get; set; }
    }

    public class Item
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Source source { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User user { get; set; }
        public string visibility { get; set; }
    }

    public class Group2
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public List<Item> items { get; set; }
    }

    public class Photos
    {
        public int count { get; set; }
        public List<Group2> groups { get; set; }
    }

    public class VenuePage
    {
        public string id { get; set; }
    }

    public class Item2
    {
        public string summary { get; set; }
        public string type { get; set; }
        public string reasonName { get; set; }
    }

    public class Reasons
    {
        public int count { get; set; }
        public List<Item2> items { get; set; }
    }

    public class Photo2
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Venue2
    {
        public string id { get; set; }
    }

    public class Tips
    {
        public int count { get; set; }
    }

    public class Group3
    {
        public string type { get; set; }
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Lists
    {
        public List<Group3> groups { get; set; }
    }

    public class Contact2
    {
    }

    public class User2
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public Photo2 photo { get; set; }
        public string type { get; set; }
        public Venue2 venue { get; set; }
        public Tips tips { get; set; }
        public Lists lists { get; set; }
        public string homeCity { get; set; }
        public string bio { get; set; }
        public Contact2 contact { get; set; }
    }

    public class Page
    {
        public User2 user { get; set; }
    }

    public class HereNow
    {
        public int count { get; set; }
        public string summary { get; set; }
        public List<object> groups { get; set; }
    }

    public class Group5
    {
        public string type { get; set; }
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Likes2
    {
        public int count { get; set; }
        public List<Group5> groups { get; set; }
        public string summary { get; set; }
    }

    public class Todo
    {
        public int count { get; set; }
    }

    public class Photo3
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class User3
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public Photo3 photo { get; set; }
        public string type { get; set; }
    }

    public class Item3
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string canonicalUrl { get; set; }
        public Likes2 likes { get; set; }
        public bool logView { get; set; }
        public int agreeCount { get; set; }
        public int disagreeCount { get; set; }
        public Todo todo { get; set; }
        public User3 user { get; set; }
    }

    public class Group4
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public List<Item3> items { get; set; }
    }

    public class Tips2
    {
        public int count { get; set; }
        public List<Group4> groups { get; set; }
    }

    public class Photo4
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class User4
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string gender { get; set; }
        public Photo4 photo { get; set; }
        public string type { get; set; }
        public string lastName { get; set; }
    }

    public class Followers
    {
        public int count { get; set; }
    }

    public class Photo6
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class User5
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo6 photo { get; set; }
        public string type { get; set; }
    }

    public class Photo5
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User5 user { get; set; }
        public string visibility { get; set; }
    }

    public class Item5
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Photo5 photo { get; set; }
    }

    public class ListItems
    {
        public int count { get; set; }
        public List<Item5> items { get; set; }
    }

    public class Photo8
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class User6
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public Photo8 photo { get; set; }
    }

    public class Photo7
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public User6 user { get; set; }
        public string visibility { get; set; }
    }

    public class Item4
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public User4 user { get; set; }
        public bool editable { get; set; }
        public bool @public { get; set; }
        public bool collaborative { get; set; }
        public string url { get; set; }
        public string canonicalUrl { get; set; }
        public int createdAt { get; set; }
        public int updatedAt { get; set; }
        public bool logView { get; set; }
        public Followers followers { get; set; }
        public ListItems listItems { get; set; }
        public Photo7 photo { get; set; }
    }

    public class Group6
    {
        public string type { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public List<Item4> items { get; set; }
    }

    public class Listed
    {
        public int count { get; set; }
        public List<Group6> groups { get; set; }
    }

    public class RichStatus
    {
        public List<object> entities { get; set; }
        public string text { get; set; }
    }

    public class Open
    {
        public string renderedTime { get; set; }
    }

    public class Timeframe
    {
        public string days { get; set; }
        public bool includesToday { get; set; }
        public List<Open> open { get; set; }
        public List<object> segments { get; set; }
    }

    public class Popular
    {
        public string status { get; set; }
        public RichStatus richStatus { get; set; }
        public bool isOpen { get; set; }
        public bool isLocalHoliday { get; set; }
        public List<Timeframe> timeframes { get; set; }
    }

    public class PageUpdates
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Inbox
    {
        public int count { get; set; }
        public List<object> items { get; set; }
    }

    public class Location2
    {
        public string address { get; set; }
        public string crossStreet { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string postalCode { get; set; }
        public string cc { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public List<string> formattedAddress { get; set; }
    }

    public class Icon2
    {
        public string prefix { get; set; }
        public string suffix { get; set; }
    }

    public class Category2
    {
        public string id { get; set; }
        public string name { get; set; }
        public string pluralName { get; set; }
        public string shortName { get; set; }
        public Icon2 icon { get; set; }
        public bool primary { get; set; }
    }

    public class VenuePage2
    {
        public string id { get; set; }
    }

    public class Parent
    {
        public string id { get; set; }
        public string name { get; set; }
        public Location2 location { get; set; }
        public List<Category2> categories { get; set; }
        public VenuePage2 venuePage { get; set; }
    }

    public class Hierarchy
    {
        public string name { get; set; }
        public string lang { get; set; }
        public string id { get; set; }
        public string canonicalUrl { get; set; }
    }

    public class Item6
    {
        public string displayName { get; set; }
        public string displayValue { get; set; }
    }

    public class Group7
    {
        public string type { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public int count { get; set; }
        public List<Item6> items { get; set; }
    }

    public class Attributes
    {
        public List<Group7> groups { get; set; }
    }

    public class Source2
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class BestPhoto
    {
        public string id { get; set; }
        public int createdAt { get; set; }
        public Source2 source { get; set; }
        public string prefix { get; set; }
        public string suffix { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string visibility { get; set; }
    }

    public class HighlightColor
    {
        public string photoId { get; set; }
        public int value { get; set; }
    }

    public class HighlightTextColor
    {
        public string photoId { get; set; }
        public int value { get; set; }
    }

    public class Colors
    {
        public HighlightColor highlightColor { get; set; }
        public HighlightTextColor highlightTextColor { get; set; }
        public int algoVersion { get; set; }
    }

    public class Venue
    {
        public string id { get; set; }
        public string name { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public string canonicalUrl { get; set; }
        public List<Category> categories { get; set; }
        public bool verified { get; set; }
        public Stats stats { get; set; }
        public Likes likes { get; set; }
        public bool dislike { get; set; }
        public bool ok { get; set; }
        public double rating { get; set; }
        public string ratingColor { get; set; }
        public int ratingSignals { get; set; }
        public BeenHere beenHere { get; set; }
        public Specials specials { get; set; }
        public Photos photos { get; set; }
        public VenuePage venuePage { get; set; }
        public Reasons reasons { get; set; }
        public Page page { get; set; }
        public HereNow hereNow { get; set; }
        public int createdAt { get; set; }
        public Tips2 tips { get; set; }
        public string shortUrl { get; set; }
        public string timeZone { get; set; }
        public Listed listed { get; set; }
        public Popular popular { get; set; }
        public PageUpdates pageUpdates { get; set; }
        public Inbox inbox { get; set; }
        public Parent parent { get; set; }
        public List<Hierarchy> hierarchy { get; set; }
        public Attributes attributes { get; set; }
        public BestPhoto bestPhoto { get; set; }
        public Colors colors { get; set; }
    }

    public class Response
    {
        public Venue venue { get; set; }
    }

    public class RootObject
    {
        public Meta meta { get; set; }
        public Response response { get; set; }
    }

}
